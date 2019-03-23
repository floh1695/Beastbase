import React, { Component } from "react";

class RegisterLogin extends Component {
  render() {
    return (
      <div className="mt-5">
        <div className="mt-5">
          <div className="jumbotron jumbotron-fluid mt-10vh">
            <div className="container text-light pt-5 mt-5">
              <h1 className="display-1 mt-5">Observe Your World</h1>
              <p className="lead">Document animals in the wild.</p>
            </div>
            <a
              href="#"
              className="btn btn-primary btn-lg mt-5 mr-2"
              role="button"
              id="sign-up-btn"
            >
              Sign up
            </a>
            <a
              href="#"
              className="btn btn-dark btn-lg mt-5 ml-2"
              role="button"
              id="login-btn"
            >
              Login
            </a>
          </div>
        </div>
      </div>
    );
  }
}

export default RegisterLogin;
