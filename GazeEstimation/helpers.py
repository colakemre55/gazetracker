#relative = lambda landmark, shape: (int(landmark.x * shape[1]), int(landmark.y * shape[0]))
#relativeT = lambda landmark, shape: (int(landmark.x * shape[1]), int(landmark.y * shape[0]), 0)
relative = lambda landmark, shape: ((landmark.x * shape[1]), (landmark.y * shape[0]))
relativeT = lambda landmark, shape: ((landmark.x * shape[1]), (landmark.y * shape[0]), 0)