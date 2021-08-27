let myMap = L.map('myMap').setView([-33.455 , -70.646], 11)

var wmsLayer = L.tileLayer.wms('http://ows.mundialis.de/services/service?', {
    layers: 'TOPO-OSM-WMS'
}).addTo(myMap);

var basemaps = {
    Topography: L.tileLayer.wms('https://ide.dataintelligence-group.com/geoserver/glaciares_r10/wms', {
        layers: 'glaciares_r10_1718q1'
    }),

    Places: L.tileLayer.wms('http://ows.mundialis.de/services/service?', {
        layers: 'OSM-Overlay-WMS'
    }),

    'Topography, then places': L.tileLayer.wms('http://ows.mundialis.de/services/service?', {
        layers: 'TOPO-WMS,OSM-Overlay-WMS'
    }),

    'Places, then topography': L.tileLayer.wms('https://ide.dataintelligence-group.com/geoserver/glaciares_r10/wms', {
        layers: 'glaciares_r10_1718q1'
    })
    

    
};

L.control.layers(basemaps).addTo(myMap);

basemaps.Topography.addTo(myMap);
let marker = L.marker([-33.455, -70.646]).addTo(myMap)

let iconMarker = L.icon({
    iconUrl: '../Content/Imagen/Icon/marker.png',
    iconSize: [60, 60],
    iconAnchor: [30, 60]
})

let marker2 = L.marker([-33.455, -70.646], { icon: iconMarker }).addTo(myMap)

myMap.doubleClickZoom.disable()
myMap.on('dblclick', e => {
  let latLng = myMap.mouseEventToLatLng(e.originalEvent);

  L.marker([latLng.lat, latLng.lng], { icon: iconMarker }).addTo(myMap)
})

