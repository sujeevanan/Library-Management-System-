import {useEffect, useState} from "react";
import {BookDto} from "../../models/bookDto.ts";
import apiConnector from "../../api/apiConnector.ts";
import BookTableItem from "./BookTableItem.tsx";

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
            <table className="table">
                <thead>
                <tr>
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
            <button type="button" className="btn btn-success">Add Book</button>
        </>
    )
}