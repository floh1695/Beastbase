import React, { Component } from 'react'

class RegisterUser extends Component {
    state = {
        username: '',
        email: '',
        password: '',
        confirmPassword: ''
    }

    render() {
        const { username, email, password, confirmPassword } = this.state;
        return (
            <div className="full-height">
                <div className="card center-screen" id="register-card">
                    <div className="card-body text-light">
                        <form className="round-preset pt-4">
                            <div className="form-group text-left">
                                <label htmlFor="input-username">User Name</label>
                                <input type="email" className="form-control" id="input-username" name="username" value={username} />
                            </div>
                            <div className="form-group text-left">
                                <label htmlFor="input-email">Email</label>
                                <input type="password" className="form-control" id="input-email" name="email" value={email} />
                            </div>
                            <div className="form-group text-left">
                                <label htmlFor="input-password">Password</label>
                                <input type="email" className="form-control" id="input-password" name="password" value={password} />
                            </div>
                            <div className="form-group text-left">
                                <label htmlFor="input-password-confirm">Confirm Password</label>
                                <input type="password" className="form-control" id="input-password-confirm" name="confirmPassword" value={confirmPassword} />
                            </div>
                            <button type="submit" className="btn btn-success mt-4">Submit</button>
                        </form>
                    </div>
                </div>
            </div>
        )
    }
}

export default RegisterUser;
