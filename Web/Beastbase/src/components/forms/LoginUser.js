import React, { Component } from 'react'

class LoginUser extends Component {
    state = {
        loginUserName: '',
        loginPassword: ''
    }
    render() {
        const { loginUserName, loginPassword } = this.state;
        return (
            <div>
                <div className="card" id="login-card">
                    <div className="card-body text-light">
                        <form className="round-preset pt-4">
                            <div className="form-group text-left">
                                <label htmlFor="login-username">User Name</label>
                                <input type="text" className="form-control" id="login-username" name="loginUseName" value={loginUserName} />
                            </div>
                            <div className="form-group text-left">
                                <label htmlFor="login-password">Password</label>
                                <input type="password" className="form-control" id="login-password" name="loginPassword" value={loginPassword} />
                            </div>
                            <button type="submit" className="btn btn-success mt-4">Submit</button>
                        </form>
                    </div>
                </div>
            </div>
        )
    }
}

export default LoginUser;