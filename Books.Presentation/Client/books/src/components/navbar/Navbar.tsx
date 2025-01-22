export default function Navbar() {
    return (
        <div>
            <nav className="navbar navbar-light bg-light">
                <div className="container-fluid">
                    <a className="navbar-brand fw-bold text-success text-xl-start">Sujee's Book Library</a>
                    <form className="d-flex">
                        <input className="form-control me-2 px-3" type="search" placeholder="Search" aria-label="Search"/>
                        <button className="btn btn-outline-success" type="submit">Search</button>
                    </form>
                    <button className="btn btn-outline-primary ms-3">Sign In</button>
                    
                </div>
            </nav>

        </div>
    )
}