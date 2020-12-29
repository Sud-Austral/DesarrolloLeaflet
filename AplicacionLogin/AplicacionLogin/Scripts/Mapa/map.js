let myMap = L.map('myMap').setView([51.505, -0.09], 13)

//L.tileLayer(`https://maps.wikimedia.org/osm-intl/{z}/{x}/{y}.png`, {
//L.tileLayer(`https://a.tile.openstreetmap.org/{z}/{x}/{y}.png`, {
L.tileLayer(`https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png`, {
    //attribution: '<a style="font-size:16px;margin-left:-35% !important;background-color:black;color:white;" target="_blank" href="https://www.dataintelligence-group.com/">Data Intelligence</a>',
    attribution: '<a style="margin-left:-9% !important;" href="https://www.dataintelligence-group.com/" target="_blank"><img style="width:35%;height:35%;background-color:black" src="Content/Imagen/dataintelligence.png" /></a>',
	maxZoom: 18,
}).addTo(myMap);

let marker = L.marker([51.5, -0.09]).addTo(myMap)

let iconMarker = L.icon({
    iconUrl: 'Content/Imagen/Icon/marker.png',
    iconSize: [60, 60],
    iconAnchor: [30, 60]
})

let marker2 = L.marker([51.51, -0.09], { icon: iconMarker }).addTo(myMap)

myMap.doubleClickZoom.disable()
myMap.on('dblclick', e => {
  let latLng = myMap.mouseEventToLatLng(e.originalEvent);

  L.marker([latLng.lat, latLng.lng], { icon: iconMarker }).addTo(myMap)
})

navigator.geolocation.getCurrentPosition(
  (pos) => {
    const { coords } = pos
    const { latitude, longitude } = coords
    L.marker([latitude, longitude], { icon: iconMarker }).addTo(myMap)

    setTimeout(() => {
      myMap.panTo(new L.LatLng(latitude, longitude))
    }, 5000)
  },
  (error) => {
    console.log(error)
  },
  {
    enableHighAccuracy: true,
    timeout: 5000,
    maximumAge: 0
  })