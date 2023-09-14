const boton = document.querySelector('#boton');
const ipsum = document.querySelector('#ipsum');

$(document).ready(function () {
	$(boton).click(function () {
		$.getJSON('https://baconipsum.com/api/?callback=?',
			{ 'type': 'meat-and-filler', 'start-with-lorem': '1', 'paras': '3' },
			function (baconGoodness) {
				if (baconGoodness && baconGoodness.length > 0) {
					$(ipsum).html('');
					for (var i = 0; i < baconGoodness.length; i++)
						$(ipsum).append('<p>' + baconGoodness[i] + '</p>');
					$(ipsum).show();
				}
			});
	});
});
