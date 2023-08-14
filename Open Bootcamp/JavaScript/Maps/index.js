// Initialize and add the map
let map;
let marker;

async function initMap() {
  // The location of Uluru
  const position = { lat: -25.344, lng: 131.031 };
  const position2 = { lat: 12.344, lng: 31.031 };
  const position3 = { lat: 44.344, lng: 131.031 };
  // Request needed libraries.
  //@ts-ignore
  const { Map } = await google.maps.importLibrary("maps");
  const { AdvancedMarkerView } = await google.maps.importLibrary("marker");



  // The map, centered at Uluru
  map = new Map(document.getElementById("map"), {
    zoom: 4,
    center: position,
    mapId: "DEMO_MAP_ID",
  });

  // The marker, positioned at Uluru
  marker = new AdvancedMarkerView({
    map: map,
    position: position,
    title: "Uluru",
  });
}

initMap();

function GeoPosiciona() {
  if (navigator.geolocation) {
    const geoLoc = navigator.geolocation;
    const options = { setTimeout: 60000 };
    const watchPos = geoLoc.watchPosition(centraMapa, onError, options);
  } else {
    alert("El navegador no admite geolocalización");
  }
}

function centraMapa(position){

  let latitude=position.coords.latitude;
  let longitude=position.coor.longitude;
  const nuevaPos={ lat:latitude, lng:longitude}


  console.log("Longitud "+ nuevaPos.lat + "Latitud" +nuevaPos.lng)
  marker.setPosition(nuevaPos)
  map.setCenter(nuevaPos)
}


/*
var myLatlng = new google.maps.Latlng(-25.363882,131.044922);
var mapOptions = {
  zoom: 4,
  center: myLatlng
}
 map = new google.maps.Map(document.getElementById("map"), mapOptions);

 marker = new google.maps.Marker({
    position: myLatlng,
    title:"Hello World!"
});

// To add the marker to the map, call setMap();
marker.setMap(map);
*/

/*
function GeoPosiciona() {
  if (navigator.geolocation) {
    const geoLoc = navigator.geolocation;
    const options = { setTimeout: 60000 };
    const watchPos = geoLoc.watchPosition(centraMapa, onError, options);
  } else {
    alert("El navegador no admite geolocalización");
  }
}

function centraMapa(position){
  const nuevaPos={
    lat: position.coords.latitude,
    lng: position.coords.longitude
  }
  console.log(nuevaPos)
  marker.setPosition(nuevaPos)
  map.setCenter(nuevaPos)
}

function onError(error){
  console.error(error)
}
*/
/*
Copiado sin mas de la api de google maps
let map;

async function initMap() {
  // The location of Uluru
  const position = { lat: -25.344, lng: 131.031 };
  // Request needed libraries.
  //@ts-ignore
  const { Map } = await google.maps.importLibrary("maps");
  const { AdvancedMarkerView } = await google.maps.importLibrary("marker");

  // The map, centered at Uluru
  map = new Map(document.getElementById("map"), {
    zoom: 4,
    center: position,
    mapId: "DEMO_MAP_ID",
  });*/
