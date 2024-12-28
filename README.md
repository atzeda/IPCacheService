# IPCacheService
Retrieve cached IP details for a given IP address.


Endpoint 1: Get Cached Details

Request Type: GET
URL: http://<IP_CACHE_SERVICE_URL>/api/Cache/{ipAddress}
Description: Retrieve cached IP details for a given IP address.

Example Request:
http

GET http://localhost:5001/api/Cache/8.8.8.8
Example Response (if cached):
json

{
  "ip": "8.8.8.8",
  "city": "Mountain View",
  "region": "California",
  "country": "United States"
}
Example Response (if not cached):
json

{
  "message": "IP address not found in cache."
}

Endpoint 2: Add to Cache
Request Type: POST
URL: http://<IP_CACHE_SERVICE_URL>/api/Cache
Description: Add IP details to the cache.

Example Request:
http

POST http://localhost:5001/api/Cache
Content-Type: application/json

{
  "ipAddress": "8.8.8.8",
  "details": {
    "ip": "8.8.8.8",
    "city": "Mountain View",
    "region": "California",
    "country": "United States"
  }
}

Example Response:
json

{
  "message": "IP address details added to cache."
}
