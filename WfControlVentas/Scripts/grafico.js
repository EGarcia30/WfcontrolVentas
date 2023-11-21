jQuery.support.cors = true;
jQuery.ajax({
    url: 'http://localhost:53879/wcfReporte.svc/getTopVentas',
    type: "GET",
    dataType: "json",
    contentType: "application/json; charset=utf-8",
    processData: true,
    cache: false,
    success: function (data) {
        console.log(data);

        var arrCant = [];
        var arrNombre = [];

        for (var i = 0; i < data.length; i++) {
            arrNombre.push(data[i]["nombre"]);
            arrCant.push(data[i]["cantVenta"]);
        }

        const ctx = document.getElementById('topVenta').getContext('2d');
        const myChart = new Chart(ctx, {
            type: 'bar',
            data: {
                labels: arrNombre,
                datasets: [{
                    label: '#TopVenta',
                    data: arrCant,
                    backgroundColor: [
                        'rgba(255, 99, 132, 0.2)',
                        'rgba(54, 162, 235, 0.2)',
                        'rgba(255, 206, 86, 0.2)',
                        'rgba(75, 192, 192, 0.2)',
                        'rgba(153, 102, 255, 0.2)',
                        'rgba(255, 159, 64, 0.2)'
                    ],
                    borderColor: [
                        'rgba(255, 99, 132, 1)',
                        'rgba(54, 162, 235, 1)',
                        'rgba(255, 206, 86, 1)',
                        'rgba(75, 192, 192, 1)',
                        'rgba(153, 102, 255, 1)',
                        'rgba(255, 159, 64, 1)'
                    ],
                    borderWidth: 1
                }]
            },
            options: {
                scales: {
                    y: {
                        beginAtZero: true
                    }
                }
            }
        });
    },
    error: function (error) {
        console.log(error)
    }
});

jQuery.ajax({
    url: 'http://localhost:53879/wcfReporte.svc/getTopPago',
    type: "GET",
    dataType: "json",
    contentType: "application/json; charset=utf-8",
    processData: true,
    cache: false,
    success: function (data) {
        console.log(data);

        var arrCant = [];
        var arrNombre = [];

        for (var i = 0; i < data.length; i++) {
            arrNombre.push(data[i]["nombre"]);
            arrCant.push(data[i]["totalPago"]);
        }

        const gl = document.getElementById('topPago')
        const graficoLineal = new Chart(gl, {
            type: 'line',
            data: {
                labels: arrNombre,
                datasets: [{
                    label: '#TopPago',
                    data: arrCant,
                    fill: false,
                    borderColor: 'rgb(75, 192, 192)',
                    borderWidth: 1
                }]
            },
            options: {
                animations: {
                    tension: {
                        duration: 500,
                        easing: 'linear',
                        from: 1,
                        to: 0,
                        loop: true
                    }
                }
            },
        });
    },
    error: function (error) {
        console.log(error)
    }
})

jQuery.ajax({
    url: 'http://localhost:53879/wcfReporte.svc/getTopMarca',
    type: "GET",
    dataType: "json",
    contentType: "application/json; charset=utf-8",
    processData: true,
    cache: false,
    success: function (data) {
        console.log(data);

        var arrCant = [];
        var arrNombre = [];

        for (var i = 0; i < data.length; i++) {
            arrNombre.push(data[i]["marca"]);
            arrCant.push(data[i]["cant"]);
        }

        const gdg = document.getElementById('topMarca')
        const graficoDona = new Chart(gdg, {
            type: 'doughnut',
            data: {
                labels: arrNombre,
                datasets: [{
                    label: '#TopMarca',
                    data: arrCant,
                    backgroundColor: [
                        'rgb(255, 99, 132)',
                        'rgb(54, 162, 235)',
                        'rgb(255, 205, 86)'
                        ],
                    hoverOffset: 4
                }]
            }
        });
    },
    error: function (error) {
        console.log(error)
    }
})