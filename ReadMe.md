# Streaming Availability, Semester 3

## Intro
Streaming Availability is een webapplicatie waarmee je kunt scrollen door alle films van verschillende film streamings services. Dit zou het makkelijker moeten maken om te kunnen zien op welke website welke film staat. En wanneer je een film keuze probeert te maken zie je direct wat er allemaal beschikbaar is als keuze.

## Running the application
### Windows
 - Run the `start.bat` file
 - Wait till the docker containers are fully operational
 - Go in to the Frontend folder and open `clientapp` in powershell
 - Type `npm i` and press enter
 - Type `npm run start` and press enter
 - Open `localhost:3000` in your browser

### MacOS
 - Open the IP folder in terminal and type `docker compose up -d` and press enter
 - Wait till the docker containers are fully operational
 - Go in to the Frontend folder and open `clientapp` in terminal
 - Type `npm i` and press enter
 - Type `npm run start` and press enter
 - Open `localhost:3000` in your browser


## External Services Used
 - Streaming Availability Api / https://rapidapi.com/movie-of-the-night-movie-of-the-night-default/api/streaming-availability/details
 - Google Firebase / https://www.googleadservices.com/pagead/aclk?sa=L&ai=DChcSEwjf0amd7bD1AhWI6FEKHUgMB8IYABAAGgJ3cw&ae=2&ohost=www.google.com&cid=CAESQeD2HXkmmV4nFLAHMAkS9Zk_Lem06zQi4YtRV0WOYJKBgZ8gJ7WRLPzNLBo-SsCD9m9k1zK8Ukma0ezIYCkR6911&sig=AOD64_1R8EvZDYu-1-Lu2g1uhpt60DbihQ&q&adurl&ved=2ahUKEwi_05yd7bD1AhXIGuwKHXfCDEAQ0Qx6BAgDEAE&dct=1


## Frontend packages used
 - "typescript": "^4.1.2"
 - "@types/jest": "^26.0.15"
 - "@types/enzyme": "^3.10.10"
 - "axios": "^0.24.0"
 - "react": "^17.0.2"
 - "react-icons": "^4.3.1"
 - "react-infinite-scroll-component": "^6.1.0"
 - "react-router-dom": "^6.2.1"
