namespace LibraryManagementSystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Library library = new Library();
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("\n===== Library Management System =====");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Register Member");
                Console.WriteLine("3. Issue Book");
                Console.WriteLine("4. Return Book");
                Console.WriteLine("5. Display Available Books");
                Console.WriteLine("6. Display Issued Books");
                Console.WriteLine("7. Display All Members");
                Console.WriteLine("8. Exit");
                Console.Write("Enter your choice: ");

                int choice = int.Parse(Console.ReadLine());
                try
                {
                    switch (choice)
                    {
                        case 1:
                            {
                                Console.Write("Title: ");
                                string title = Console.ReadLine();
                                Console.Write("Author: ");
                                string author = Console.ReadLine();
                                Console.Write("ISBN: ");
                                string isbn = Console.ReadLine();
                                Console.Write("Total copies: ");
                                int copies = int.Parse(Console.ReadLine());

                                Book book = new Book(title, author, isbn, copies);
                                library.AddBook(book);
                                break;
                            }
                        case 2:
                            {
                                Console.Write("Name: ");
                                string name = Console.ReadLine();
                                Console.Write("Member Id: ");
                                string mId = Console.ReadLine();
                                Console.Write("Membership type (Regular/Premium): ");
                                string mType = Console.ReadLine();

                                Member newMember = new Member(name, mId, mType);
                                library.RegisterMember(newMember);

                                break;
                            }
                        case 3:
                            {
                                Console.Write("ISBN Code: ");
                                string issueIsbn = Console.ReadLine();
                                Console.Write("Member id: ");
                                string issueMemberId = Console.ReadLine();

                                library.IssueBook(issueIsbn, issueMemberId);
                                break;
                            }
                        case 4:
                            {
                                Console.Write("ISBN Code: ");
                                string returnIsbn = Console.ReadLine();
                                Console.Write("Member id: ");
                                string returnMemberId = Console.ReadLine();

                                library.ReturnBook(returnIsbn, returnMemberId);
                                break;
                            }
                        case 5:
                            {
                                library.DisplayAvailableBooks();
                                break;
                            }
                        case 6:
                            {
                                library.DisplayIssuedBooks();
                                break;
                            }
                        case 7:
                            {
                                library.DisplayAllMember();
                                break;
                            }
                        case 8:
                            {
                                flag = false;
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Invalid choice. Try again.");
                                break;
                            }
                    }
                }
                catch (FormatException){
                    Console.WriteLine("Invalid input format. Please enter correct data type.");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Validation Error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Unexpected Error: {ex.Message}");
                }
            }
        }
    }
}