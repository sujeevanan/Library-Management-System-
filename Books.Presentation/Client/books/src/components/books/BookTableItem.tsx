import {BookDto} from "../../models/bookDto.ts";
import apiConnector from "../../api/apiConnector.ts";
import {NavLink} from "react-router-dom";

interface Props{
    book:BookDto;
}

export default function BookTableItem({book}:Props) {
    return (
        <>
            <tr >
                <td>{book.id}</td>
                <td>{book.title}</td>
                <td>{book.author}</td>
                <td>{book.description}</td>
                <td>{book.category}</td>
                <td>{book.createDate}</td>
                <td >
                    <div className="d-grid gap-2 d-md-flex justify-content-md-end">
                        <NavLink to={`editBook/${book.id}`} className="btn btn-warning">
                            Edit
                        </NavLink>
                        <button type="button" className="btn btn-danger" onClick={async ()=>{
                            await apiConnector.deleteBook(book.id!);
                            window.location.reload();
                        }}>Delete</button>
                    </div>
                   
                </td>
            </tr>
        </>
    )
}