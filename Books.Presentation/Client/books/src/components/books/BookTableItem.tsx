import {BookDto} from "../../models/bookDto.ts";
import apiConnector from "../../api/apiConnector.ts";

interface Props{
    book:BookDto;
}

export default function BookTableItem({book}:Props) {
    return (
        <>
            <tr>
                <td>{book.id}</td>
                <td>{book.title}</td>
                <td>{book.author}</td>
                <td>{book.description}</td>
                <td>{book.category}</td>
                <td>{book.createDate}</td>
                <td>
                    <button type="button" className="btn btn-warning">Edit</button>
                    <button type="button" className="btn btn-danger" onClick={async ()=>{
                        await apiConnector.deleteBook(book.id!);
                        window.location.reload();
                    }}>Delete</button>
                </td>
            </tr>
        </>
    )
}