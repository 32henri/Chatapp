#!/bin/bash

# Get the current number of chatconsole containers running
num_consoles=$(docker ps -f "name=chatconsole" --format "{{.Names}}" | wc -l)

# Calculate the next available USER_ID (e.g., user1, user2, ...)
user_id="user$((num_consoles + 1))"

# Set the USER_ID as an environment variable
export USER_ID=$user_id

# Start a new chatconsole instance using docker-compose and the dynamic USER_ID
docker-compose up -d --scale chatconsole=$((num_consoles + 1))

echo "Created new chatconsole instance with USER_ID: $user_id"
