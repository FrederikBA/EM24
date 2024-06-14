import React, { useState } from 'react';
import { NavLink } from 'react-router-dom';
import Dropdown from 'react-bootstrap/Dropdown';

const Header = () => {
    const [activeItem, setActiveItem] = useState("UEFA EURO 2024");

    const handleSelect = (eventKey) => {
        setActiveItem(eventKey);
    };

    return (
        <div className="header">
            <Dropdown onSelect={handleSelect}>
                <Dropdown.Toggle className="nav-dropdown" variant="success" id="dropdown-basic">
                    <img src="/icons/uefa-euro.webp" alt="uefaicon" className="icon" />
                    UEFA EURO <span className="bold">2024</span>
                </Dropdown.Toggle>

                <Dropdown.Menu className="nav-dropdown-menu">
                    <NavLink to="/" className="nav-link-custom">
                        <Dropdown.Item as="li" className="nav-dropdown-item" eventKey="SEA HEALTH & WELFARE APPLICATIONS">
                            <img src="/icons/uefa-euro.webp" alt="uefaicon" className="icon dropdown-item-icon" />
                            UEFA EURO <span className="bold">2024</span>
                        </Dropdown.Item>
                    </NavLink>
                    <NavLink to="/matches" className="nav-link-custom">
                        <Dropdown.Item as="li" className="nav-dropdown-item nav-dropdown-item-bold">
                            Kampe
                        </Dropdown.Item>
                    </NavLink>
                    <NavLink to="/players" className="nav-link-custom">
                        <Dropdown.Item as="li" className="nav-dropdown-item nav-dropdown-item-bold">
                            Spillere
                        </Dropdown.Item>
                    </NavLink>
                </Dropdown.Menu>
            </Dropdown>
        </div>
    );
};

export default Header;
