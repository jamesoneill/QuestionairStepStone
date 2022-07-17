#!/bin/bash

echo "Building"

docker build -t questionnair:latest .

echo "Running"

docker run -d --publish 5000:80 questionnair:latest
