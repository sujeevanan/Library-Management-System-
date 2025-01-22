import {useEffect, useState} from "react";
import {BookDto} from "../../models/bookDto.ts";
import apiConnector from "../../api/apiConnector.ts";
import BookTableItem from "./BookTableItem.tsx";
import {NavLink} from "react-router-dom";

export default function BookTable() {
    const[books,setBooks]=useState<BookDto[]>([]);
    useEffect(()=>{
        const fetchData=async ()=>{
            const fetchedBooks=await apiConnector.getBooks();
            setBooks(fetchedBooks);
        }
        fetchData();
    },[])
    return (
        <>
            <div className="container">
                <table className="table table-striped table-hover ">
                    <thead>
                    <tr className="table-dark">
                        <th>Id</th>
                        <th>Title</th>
                        <th>Author</th>
                        <th>Description</th>
                        <th>Category</th>
                        <th>CreateDate</th>
                        <th>Action</th>

                    </tr>
                    </thead>
                    <tbody>
                    {books.length > 0 && (
                        books.map((book, index) => (
                            <BookTableItem key={index} book={book}/>
                        ))
                    )}
                    </tbody>
                </table>
                <div className="d-grid justify-content-md-end">
                    <NavLink to="createBook" className="btn btn-success px-4 ">
                        Add Book
                    </NavLink>
                </div>
               
            </div>


        </>
    )
}