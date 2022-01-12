import { Link } from "react-router-dom";
import "../Style/Components/Navbar.css";
import { AiOutlineSearch, AiOutlineUser, AiFillPlayCircle } from "react-icons/ai";
import Popup from "reactjs-popup";
import "reactjs-popup/dist/index.css";

export const Navbar = () => {
    return (
        <nav className="navbar">
            <ul className="navbar-nav">
                <li className="nav-item">
                    <Popup
                        trigger={
                            <div className="nav-link">
                                <AiOutlineSearch size="3rem" className="link-icon" />
                                <span className="link-text">Search</span>
                            </div>
                        }
                        position="top center"
                    >
                        <div>
                            <form action="/">
                                <input type="text" placeholder="Search.." name="search" />
                                <button type="submit">
                                    <AiOutlineSearch size="1sssrem" className="link-icon" />
                                </button>
                            </form>
                        </div>
                    </Popup>
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
        </nav>
    );
};
