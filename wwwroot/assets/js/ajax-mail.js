$(function () {

    // Get the form.
    var form = $('#contact-form');

    // Get the messages div.
    var formMessages = $('.form-messege');

    // Set up an event listener for the contact form.
    $(form).submit(function (e) {
        // Stop the browser from submitting the form.
        e.preventDefault();

        // Serialize the form data.
        var formData = $(form).serialize();
        $(formMessages).text("");
        $(".preloader").show();
        // Submit the form using AJAX.
        $.ajax({
            type: 'POST',
            url: $(form).attr('action'),
            data: formData
        }).done(function (response) {
                // Make sure that the formMessages div has the 'success' class.
                //$(formMessages).removeClass('error');
                //$(formMessages).removeClass('success');


            if (response.status == "success") {
                $(formMessages).html('<div class="alert alert-danger">' + response.mensagem + '</div>');
                    // Clear the form.
                    $('#contact-form input,#contact-form textarea').val('');
                }
                if (response.status == "error") {
                    //$(formMessages).addClass('error');
                    $(formMessages).html('<div class="alert alert-danger">' + response.mensagem + '</div>');
                }


            }).fail(function (data) {
                // Make sure that the formMessages div has the 'error' class.
                //$(formMessages).removeClass('success');
                //$(formMessages).addClass('error');

                // Set the message text.
                if (data.responseText !== '') {
                    $(formMessages).html('<div class="alert alert-success">' + response.mensagem + '</div>');
                } else {
                    //$(formMessages).text('Oops! An error occured and your message could not be sent.');
                    $(formMessages).html('<div class="alert alert-danger">Oooppsss, houve um erro ao tentar enviar a mensagem. Tente novamente mais tarde!</div>');
                }
            }).always(function () {
                $(".preloader").hide();
            });
    });

});
