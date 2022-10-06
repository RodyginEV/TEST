/* Автор, название и год издания той книги, которая представлена в библиотеке меньше всего. */
SELECT a.name, b.name, b.year, COUNT(*)
FROM book_card AS bc
JOIN authors AS a ON bc.authors_id = a.authors_id
JOIN books AS b ON bc.book_id = b.book_id
GROUP BY b.name
ORDER BY  4

/* Количество книг по годам издания */
SELECT DISTINCT year, quantity
FROM books
ORDER BY year

/* Названия книг автора, книг которого в библиотеке представлено больше всего */
SELECT b.name, COUNT(bc.author_id)
FROM book_card AS bc
JOIN books AS b ON bc.book_id = b.book_id
GROUP BY b.name
ORDER BY 2 DESC
