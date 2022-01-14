import { BrowserRouter as Router, Routes, Route } from "react-router-dom";

import Homepage from "./Pages/Home";
import Userpage from "./Pages/User";

import "./Style/App.css";
import { Navbar } from "./Components/Navbar";

function App() {
    return (
        <Router>
            <Navbar />
            <div>
                <div className="page-body">
                    <Routes>
                        <Route path="/user" element={<Userpage />} />
                        <Route path="/" element={<Homepage />} />
                    </Routes>
                </div>
            </div>
        </Router>
    );
}

export default App;
