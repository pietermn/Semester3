import axios from "axios";

const instance = axios.create({
    baseURL: "http://localhost:5300/",
});

export default instance;
