﻿using Library.Domain;

namespace Library.Infrastructure.Data.BookModel
{
    public interface IBookRepository
    {
        List<Book> GetAll();
        Book Get( int id );
        int Create( Book book );
        void Delete( Book book );
        void Update( Book book );
    }
}
