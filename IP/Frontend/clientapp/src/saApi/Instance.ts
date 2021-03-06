import axios from "axios";
import { setupCache } from "axios-cache-adapter";

const cache = setupCache({
    maxAge: 15 * 60 * 1000
});

const instance = axios.create({
    baseURL: "http://localhost:5300/",
    adapter: cache.adapter
});

export default instance;
