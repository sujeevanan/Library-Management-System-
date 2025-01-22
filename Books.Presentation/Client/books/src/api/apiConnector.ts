import {BookDto} from "../models/bookDto.ts";
import axios, {AxiosResponse} from "axios";
import {getBooksResponse} from "../models/getBooksResponse.tsx";
import {API_BASE_URL} from "../../config.ts";
import {getBookByIdResponse} from "../models/getBookByIdResponse.tsx";

const apiConnector = {
    //get all the books 
    getBooks:async () : Promise<BookDto[]> => {
        try {
            const response:AxiosResponse<getBooksResponse> = await axios.get(`${API_BASE_URL}/books`);
            const books=response.data.bookDtos.map(book=>({
                ...book,
                createDate:book.createDate?.slice(0,10)??""
            }));
            return books;
        }catch(error){
            console.error("Error fetching books", error);
            throw error;
        }
    },
    
    //create a book
    createBook:async (book:BookDto) : Promise<void> => {
        try {
            await axios.post<number>(`${API_BASE_URL}/books`, book);
        }catch(error){
            console.log(error);
            throw error;
        }
    },
    
    //edit movie 
    editBook:async (book:BookDto) : Promise<void> => {
        try {
            await axios.put<number>(`${API_BASE_URL}/books/${book.id}`, book);
        }catch (error){
            console.log(error);
            throw error;
        }
    },
    
    //delete the book
    deleteBook:async (bookId:number) : Promise<void> => {
        try {
            await axios.delete<number>(`${API_BASE_URL}/books/${bookId}`);
        }catch(error){
            console.log(error);
            throw error;
        }
    },
    //get the book by id 
    getBookById:async (bookId:string) : Promise<BookDto|undefined> => {
        try {
            const response=await axios.get<getBookByIdResponse>(`${API_BASE_URL}/books/${bookId}`);
            return response.data.bookDto;
        }catch(error){
            console.log(error);
            throw error;
        }
      
    }
}
export default apiConnector;