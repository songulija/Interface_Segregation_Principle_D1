using System;

namespace DemoLibrary
{
    /// <summary>
    /// Interface segregation principle. here is problem that Book,DVD,ReferenceBook
    /// all implement this interface but DONT use all or even half fields and methods. which is not good
    /// I should bring this down into smaller classes
    /// </summary>
    public interface ILibraryItem
    {
        //library item has only id,title
        string LibraryId { get; set; }
        string Title { get; set; }
        //DateTime BorrowDate { get; set; }
        //string Borrower { get; set; }
        //int CheckOutDurationInDays { get; set; }
        //thats for book but not for DVD,referenceBook
        

        //void CheckIn();
        //void CheckOut(string borrower);
        //DateTime GetDueDate();
    }
}