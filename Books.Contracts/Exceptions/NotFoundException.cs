namespace Books.Contracts.Exceptions;

public class NotFoundException(string message) : Exception(message);
