
import './App.css'
import BookTable from "./components/books/BookTable.tsx";
import {Outlet, useLocation} from "react-router-dom";
import Navbar from "./components/navbar/Navbar.tsx";

function App() {
  const location = useLocation();

  return (
    <>
        <Navbar/>
      <div className="mt-xxl-5 min-vh-100">
        {location.pathname === '/' ? (
            <BookTable />
        ) : (
            <div className="container">
              {/*to take the children routes */}
              <Outlet />
            </div>
        )}
      </div>
    

    </>
  )
}

export default App
