#!/bin/bash

echo "Building"

docker build -t questionair:latest .

echo "Running"

docker run -d --publish 5000:80 questionair:latest
