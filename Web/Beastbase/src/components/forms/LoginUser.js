import React, { Component } from 'react'

class LoginUser extends Component {
    state = {
        loginUserName: '',
        loginPassword: ''
    }

    onChange = (e) => this.setState({ [e.target.name]: e.target.value });
    onSubmit = (e) => {
        e.preventDefault();
        console.log(this.state);
    }


    render() {
        const { loginUserName, loginPassword } = this.state;
        return (
            <div>
                <div className="card center-screen" id="login-card">
                    <div className="card-body text-light">
                        <form className="round-preset pt-4" onSubmit={this.onSubmit}>
                            <div className="form-group text-left">
                                <label htmlFor="login-username">User Name</label>
                                <input type="text" className="form-control" id="login-username" name="loginUserName" value={loginUserName} onChange={this.onChange} />
                            </div>
                            <div className="form-group text-left">
                                <label htmlFor="login-password">Password</label>
                                <input type="password" className="form-control" id="login-password" name="loginPassword" value={loginPassword} onChange={this.onChange} />
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