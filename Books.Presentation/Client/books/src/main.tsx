import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'
import './App.css'
import App from './App.tsx'
import 'bootstrap/dist/css/bootstrap.min.css';
import {router} from "./router/Routes.tsx";
import {RouterProvider} from "react-router-dom";


createRoot(document.getElementById('root')!).render(
  <StrictMode>
   <RouterProvider router={router}/>
  </StrictMode>,
)
