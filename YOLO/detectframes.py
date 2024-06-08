import os
import shutil
import torch
from PIL import ImageFile
ImageFile.LOAD_TRUNCATED_IMAGES = True
from PIL import Image

def framesObjectDetection(folderPath, outputFolderPath):
    # Load the YOLOv5 model
    model = torch.hub.load('ultralytics/yolov5', 'yolov5s')  # Load a pre-trained model

    # List image files in the folder path
    imageFiles = [f for f in os.listdir(folderPath) if f.endswith(('.jpg', '.jpeg', '.png'))]

    # Create the output directory if it doesn't exist
    os.makedirs(outputFolderPath, exist_ok=True)

    # Path for the results text file
    outputResultsTXTPath = os.path.join(outputFolderPath, "results.txt")

    all_results = []

    # Process each image
    for frameNumber, image in enumerate(imageFiles):
        imagePath = os.path.join(folderPath, image)
        results = model(imagePath)
        df = results.pandas().xyxy[0]  # Results as a DataFrame

        temp_save_dir = os.path.join(outputFolderPath, "temp_save")
        os.makedirs(temp_save_dir, exist_ok=True)
        if not df.empty:
            for index, row in df.iterrows():
                class_name = row['name']
                # Crop image to the detected object
                img = Image.open(imagePath)
                crop_img = img.crop((int(row['xmin']), int(row['ymin']), int(row['xmax']), int(row['ymax'])))
                crop_path = os.path.join(temp_save_dir, f"{frameNumber}_{class_name}_{index}.jpg")
                crop_img.save(crop_path)
                # Append frame number, class name, bounding box dimensions, and coordinates
                detection_details = {
                    'frame_number': frameNumber,
                    'class': row['name'],
                    'xmin': row['xmin'],
                    'ymin': row['ymin'],
                    'xmax': row['xmax'],
                    'ymax': row['ymax']
                }
                all_results.append(detection_details)
        else:
            all_results.append({
                'frame_number': frameNumber,
                'class': '0',
                'xmin': 0,
                'ymin': 0,
                'xmax': 0,
                'ymax': 0
            })  # No objects detected

        # Temporary directory for saving processed images
        #temp_save_dir = os.path.join(outputFolderPath, "temp_save")
        #results.save(save_dir=temp_save_dir)

        # Move processed images from temp_save to output folder
        for file in os.listdir(temp_save_dir):
            file_path = os.path.join(temp_save_dir, file)
            shutil.move(file_path, outputFolderPath)
        
        # Remove the temporary directory
        os.rmdir(temp_save_dir)

    return all_results
