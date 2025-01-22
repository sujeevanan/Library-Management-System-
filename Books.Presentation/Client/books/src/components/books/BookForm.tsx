import {NavLink, useNavigate, useParams} from "react-router-dom";
import {BookDto} from "../../models/bookDto.ts";
import {ChangeEvent, useEffect, useState} from "react";
import apiConnector from "../../api/apiConnector.ts";

export default function BookForm() {
    const {id}=useParams();
    const navigate = useNavigate();
    const[book,setBook]=useState<BookDto>({
        id:undefined,
        title:'',
        author:'',
        description:'',
        createDate:undefined,
        category:''
    });
    useEffect(()=>{
        if(id){
            apiConnector.getBookById(id).then(book=>setBook(book!))
        }
    },[id])
    function handleSubmit(e:React.FormEvent<HTMLFormElement>) {
        e.preventDefault();
        if(!book.id){
            apiConnector.createBook(book).then(()=>navigate("/"));
        }else{
            apiConnector.editBook(book).then(()=>navigate("/"));
        }
    }
    function handleInputChange(event:ChangeEvent<HTMLInputElement|HTMLTextAreaElement>) {
        const {name, value} = event.target;
        setBook({...book, [name]: value});
    }
     return (
        <div className="container mt-4">
            <form onSubmit={handleSubmit} autoComplete="off" className="needs-validation">
                <div className="mb-3">
                    <label htmlFor="title" className="form-label">
                        Title
                    </label>
                    <input
                        type="text"
                        id="title"
                        name="title"
                        value={book.title}
                        onChange={handleInputChange}
                        placeholder="Title"
                        className="form-control"
                        required
                    />
                </div>
                <div className="mb-3">
                    <label htmlFor="title" className="form-label">
                        Author
                    </label>
                    <input
                        type="text"
                        id="author"
                        name="author"
                        value={book.author}
                        onChange={handleInputChange}
                        placeholder="Author"
                        className="form-control"
                        required
                    />
                </div>

                <div className="mb-3">
                    <label htmlFor="description" className="form-label">
                        Description
                    </label>
                    <textarea
                        id="description"
                        name="description"
                        value={book.description}
                        onChange={handleInputChange}
                        placeholder="Description"
                        className="form-control"
                        required
                    />
                </div>

                <div className="mb-3">
                    <label htmlFor="category" className="form-label">
                        Category
                    </label>
                    <input
                        type="text"
                        id="category"
                        name="category"
                        value={book.category}
                        onChange={handleInputChange}
                        placeholder="Category"
                        className="form-control"
                        required
                    />
                </div>

                <div className="d-flex justify-content-end">
                    <button type="submit" className="btn btn-success me-2">
                        Submit
                    </button>
                    <NavLink to="/" className="btn btn-secondary">
                        Cancel
                    </NavLink>
                </div>
            </form>
        </div>
     );
}