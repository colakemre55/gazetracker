# Sample Python script for YOLOv5 object detection
import torch
from pathlib import Path
from models.experimental import attempt_load
from utils.general import non_max_suppression, scale_coords, plot_one_box

# Load YOLOv5 model
weights = 'path/to/your/model/weights.pt'
model = attempt_load(weights, map_location=torch.device('cuda' if torch.cuda.is_available() else 'cpu'))

# Process video frames
video_path = "C:\Users\colak\Downloads\popcorn.mp4"

cap = cv2.VideoCapture(video_path)
while cap.isOpened():
    ret, frame = cap.read()
    if not ret:
        break

    # Perform YOLOv5 object detection
    results = model(frame)

    # Process results (e.g., draw bounding boxes on the frame)
    # ...

    # Display the frame (optional)
    cv2.imshow('Object Detection', frame)

    # Press 'q' to exit
    if cv2.waitKey(1) & 0xFF == ord('q'):
        break

cap.release()
cv2.destroyAllWindows()
