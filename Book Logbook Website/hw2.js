$(document).ready(function () {
    var image = new Image();
    image.src = 'overlords.jpg';

    $('.ai-button').click(function () {
        let clicked = false;
        alert('Vote has been cast!');
        clicked = true;
        if (clicked === true) {
            $(image).appendTo(".section1");
        }
    });

    $(image).css({
        height: '300px',
        width: '400px',
        position: 'relative',
        left: '560px',
        top: '20px'
    });

    $('#owned').click(function () {
        var title = $('#title').val();
        var author = $('#author').val();
        var type = $('#type').val();

        var newBook = '<tr class="book"> <td>' + title + '</td><td>' + author + '</td><td>' + type + '</td></tr>';

        if (title === "" && author === "") {
            alert('Book missing title and author');
        } else if (title === "") {
            alert('Book missing title');
        } else if (author === "") {
            alert('Book missing author');
        } else {
            $(newBook).appendTo('.owned-table');
        }
    });

    $('#wishlist').click(function () {
        var title = $('#title').val();
        var author = $('#author').val();
        var type = $('#type').val();

        var newBook = '<tr class="book"> <td>' + title + '</td><td>' + author + '</td><td>' + type + '</td></tr>';

        if (title === "" && author === "") {
            alert('Book missing title and author');
        } else if (title === "") {
            alert('Book missing title');
        } else if (author === "") {
            alert('Book missing author');
        } else {
            $(newBook).appendTo('.wishlist-table');
        }
    });
});
