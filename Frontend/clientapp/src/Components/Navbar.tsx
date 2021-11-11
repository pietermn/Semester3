import {
    Link
  } from "react-router-dom";
import '../Style/Components/Navbar.css';
import { AiOutlineSearch, AiOutlineUser, AiFillPlayCircle } from 'react-icons/ai';


export const Navbar = () => {
    return <nav className="navbar">

        <ul className="navbar-nav">

            <li className="nav-item">
                <Link to="/search" className="nav-link">
                    <AiOutlineSearch size="3rem" className="link-icon" />
                    <span className="link-text">Search</span>
                </Link>
            </li>

            <li className="nav-item">
                <Link to="/" className="nav-link">
                    <AiFillPlayCircle size="3rem" className="link-icon" />
                    <span className="link-text">Home</span>
                </Link>
            </li>

            <li className="nav-item">
                <Link to="/user" className="nav-link">
                    <AiOutlineUser size="3rem" className="link-icon" />
                    <span className="link-text">User</span>
                </Link>
            </li>
        </ul>
        
  </nav>;
};