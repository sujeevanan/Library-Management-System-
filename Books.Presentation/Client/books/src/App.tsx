
import './App.css'
import BookTable from "./components/books/BookTable.tsx";
import {Outlet, useLocation} from "react-router-dom";

function App() {
  const location = useLocation();

  return (
    <>
        {location.pathname === '/' ? (
            <BookTable />
        ) : (
            <div className="container">
                {/*to take the children routes */}
                <Outlet />
            </div>
        )}

    </>
  )
}

export default App
