import React, { Component } from "react";

class Navbar extends Component {
  render() {
    return (
      <div>
        <nav className="navbar navbar-expand-lg charcoal fixed-top">
          <a className="navbar-brand text-light" href="#">
            Beastbase
          </a>
          <button
            className="navbar-toggler"
            type="button"
            data-toggle="collapse"
            data-target="#navbarNavAltMarkup"
            aria-controls="navbarNavAltMarkup"
            aria-expanded="false"
            aria-label="Toggle navigation"
          >
            <span className="navbar-toggler-icon" />
          </button>
          <div
            className="collapse navbar-collapse d-flex justify-content-end"
            id="navbarNavAltMarkup"
          >
            <ul className="navbar-nav d-flex justify-content-end">
              <li className="nav-item">
                <a className="nav-link text-light" href="#">
                  Home
                </a>
              </li>
              <li className="nav-item">
                <a className="nav-link text-light" href="#">
                  Beast Listing
                </a>
              </li>
              <li className="nav-item">
                <a className="nav-link text-light" href="#">
                  About Beastbase
                </a>
              </li>
              <li className="nav-item">
                <a className="nav-link text-light" href="#">
                  Developers
                </a>
              </li>
            </ul>
          </div>
        </nav>
      </div>
    );
  }
}

export default Navbar;
