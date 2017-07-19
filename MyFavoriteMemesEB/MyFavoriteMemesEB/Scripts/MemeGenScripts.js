$(".select-image").click(function () {
    $(".select-image").css('border', '50px solid #ffffff')
    $(".select-image").removeClass('selected')

    $(this).css('border', '0px solid #ffffff')
    $(this).addClass('selected')

    $("#SubmitMeme_MemeId").val($(this).find('input').val())
    $("#SubmitMeme_ImageUrl").val($(this).find('img').attr('src'))
})


$('#memeForm').submit(function validateMemeGen(e) {
    var id = $("#SubmitMeme_MemeId").val()
    var url = $("#SubmitMeme_ImageUrl").val()
    var topT = $("#SubmitMeme_TopText").val()
    var botT = $("#SubmitMeme_BottomText").val()

    if(id === "" || url === "") {
        alert("Please make an image selection");
        e.preventDefault();
    }

    if (topT === "" && botT === "") {
        alert("Please write something");
        e.preventDefault();
    }
})