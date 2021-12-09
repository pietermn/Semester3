import React from "react";
import { BrowserRouter as Router, Switch, Route } from "react-router-dom";

import Homepage from "./Pages/Home";
import Userpage from "./Pages/User";
import Searchpage from "./Pages/Search";

import { initializeApp } from 'firebase/app';
import "firebase/auth";
import { getAuth, onAuthStateChanged } from "firebase/auth";

import "./Style/App.css";
import { Navbar } from "./Components/Navbar";

const firebaseConfig = {
    apiKey: "AIzaSyDhY05vh6PirsouOR6vzdiQcNbTL1jTzoM",
    authDomain: "streamavailability.firebaseapp.com",
    projectId: "streamavailability",
    storageBucket: "streamavailability.appspot.com",
    messagingSenderId: "861910595260",
    appId: "1:861910595260:web:7d46bac89071fc2d4702b9",
    measurementId: "G-P217LR2E97",
};

// Initialize Firebase
const app = initializeApp(firebaseConfig);


function App() {
    return (
        <Router>
            <Navbar />
            <div>
                <div className="page-body">
                    <Switch>
                        <Route path="/search">
                            <Searchpage />
                        </Route>
                        <Route path="/user">
                            <Userpage />
                        </Route>
                        <Route path="/">
                            <Homepage />
                        </Route>
                    </Switch>
                </div>
            </div>
        </Router>
    );
}

export default App;
