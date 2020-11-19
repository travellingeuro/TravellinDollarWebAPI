﻿function Initialmap() {
    var mapOptions = {
        center: new google.maps.LatLng(38.89037, -77.03196),
        zoom: 8,
        mapTypeId: 'terrain',
        streetViewControl: false,
        mapTypeControl: false,
        fullscreenControl: false
    };

    //Getting map DOM element
    var mapElement = document.getElementById('mapa');

    //Creating a map with DOM element which is just obtained
    map = new google.maps.Map(mapElement, mapOptions);
}