


$(function () {
    var mostrarModal = $('#mostarModalAqui');
    $('button[data-toggle="ajax-modal"]').click(function (event) {
        var url = $(this).data('url');
        var codificarURL = decodeURIComponent(url);
        $.get(codificarURL).done(function (data) {
            mostrarModal.html(data);
            mostrarModal.find('.modal').modal('show');
        });
    });
    mostrarModal.on('click', '[data-save="modal"]', function (event) {
        event.preventDefault();
        var form = $(this).parents('.modal').find('form');
        var actionUrl = form.attr('action');
        var Datos = form.serialize();
        $.post(actionUrl, Datos).done(function (data) {
            var formulario = $('.modal-body', data);
            mostrarModal.find('.modal-body').replaceWith(formulario);
            var Validar = formulario.find('#IsValid').val() == 'True';
            if (Validar) {
                mostrarModal.find('.modal').modal('hide');
                location.reload();
            }
        });

    });

});

