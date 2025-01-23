### **Library Management System**  

The Library Management System is a web-based CRUD application developed to manage book records efficiently. This project focuses on book management, allowing administrators to perform Create, Read, Update, and Delete operations seamlessly.

---

### **Features**  
1. **Book Management**  
   - Add new books to the system.  
   - View detailed information about books, including title, author, genre, and publication date.  
   - Update existing book records.  
   - Delete books from the system.  

2. **Frontend Features**  
   - Built with React and TypeScript for a robust and type-safe user interface.  
   - Responsive design implemented using Bootstrap 5.  

3. **Backend Features**  
   - Developed with .NET Core Web API for high performance and scalability.  
   - SQLite database integrated with Entity Framework for easy and efficient data management.  

---

### **Technologies Used**  
#### **Frontend**  
- **Framework**: React.js with TypeScript  
- **UI Library**: Bootstrap 5  

#### **Backend**  
- **Framework**: .NET Core Web API  
- **Database**: SQLite  
- **ORM**: Entity Framework Core  

---

### **System Requirements**  
- **Frontend**:  
  - Node.js v14 or higher  
  - Modern web browser  

- **Backend**:  
  - .NET SDK (6.0 or higher)  
  - SQLite installed  

---

### **Setup Instructions**  

#### **Backend Setup**  
1. Clone the repository and navigate to the backend folder.  
2. Restore the dependencies:  
   ```bash  
   dotnet restore  
   ```  
3. Update the SQLite database with Entity Framework migrations:  
   ```bash  
   dotnet ef database update  
   ```  
4. Run the application:  
   ```bash  
   dotnet run  
   ```  
   The backend will be available at `http://localhost:<port>`.

#### **Frontend Setup**  
1. Navigate to the frontend folder.  
2. Install dependencies:  
   ```bash  
   npm install  
   ```  
3. Start the development server:  
   ```bash  
   npm start  
   ```  
   The frontend will be available at `http://localhost:3000`.

---

### **Endpoints**  
Here are the primary API endpoints for book management:  
- **GET** `/api/books` – Retrieve a list of all books.  
- **GET** `/api/books/{id}` – Retrieve details of a specific book.  
- **POST** `/api/books` – Add a new book.  
- **PUT** `/api/books/{id}` – Update details of an existing book.  
- **DELETE** `/api/books/{id}` – Remove a book from the system.  

---

### **Future Enhancements**  
- User and member management modules.  
- Borrowing and returning functionality.  
- Integration with external APIs for book details.  
- Advanced search and filtering features.  

---

### **Contact**  
For questions or contributions, please contact:  
- **Email**: [lsujee2000@gmail.com]  
- **GitHub**: [Your GitHub Profile]([https://github.com/your-username](https://github.com/sujeevanan))  

---

This project is an excellent starting point for building a full-featured Library Management System. Feedback and contributions are welcome!
