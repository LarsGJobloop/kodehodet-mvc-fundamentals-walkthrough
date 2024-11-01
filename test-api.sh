#!/bin/bash

curl -s \
-X POST \
-H "Content-Type: application/json" \
-d '{"title": "A", "body": "Hello"}' \
http://localhost:5234/blog


curl -s \
http://localhost:5234/blog