import os
import shutil
import torch
from PIL import ImageFile
ImageFile.LOAD_TRUNCATED_IMAGES = True


def framesObjectDetection(folderPath , outputFolderPath):

    model  = torch.hub.load('ultralytics/yolov5', 'yolov5s')  # yolov5n - yolov5x6 official model   ('custom', 'path/to/best.pt')  # custom model                                 
    imageFiles = [f for f in os.listdir(folderPath) if f.endswith(('.jpg', '.jpeg', '.png'))]

    os.makedirs(outputFolderPath, exist_ok=True)

    outputResultsTXTPath = os.path.join(outputFolderPath, "results.txt")

    all_results = []

    for frameNumber, image in enumerate(imageFiles):
        imagePath = os.path.join(folderPath, image)

        results = model(imagePath)
        
        df = results.pandas().xyxy[0]

        if not df.empty:
            for i in df['name']:  # name->labels
                all_results.append((frameNumber, i))
        else:
            all_results.append((frameNumber, '0')) # if no objects detected

        temp_save_dir = os.path.join(outputFolderPath, "temp_save")
        results.save(save_dir = temp_save_dir )


        for file in os.listdir(temp_save_dir):
            file_path = os.path.join(temp_save_dir, file)
            shutil.move(file_path, outputFolderPath)
        
        os.rmdir(temp_save_dir)
        

    # Write results to text file
    with open(outputResultsTXTPath, 'w') as f:
        for frameNumber, obj in all_results:
            f.write(f"Frame:{frameNumber} {obj}\n")


    return all_results;
