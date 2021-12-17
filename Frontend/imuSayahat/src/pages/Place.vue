<template>
    <q-page class="container">
        <div class="q-px-md">
            <h3>{{placeInfo.placeName}}</h3>
        </div>
        <div class="row q-col-gutter-md justify-between">
            <div class="col-xs-12 col-md-8">
                <div class="q-px-md q-mb-xl">
                    <q-img
                        :src="placeInfo.imageURL"
                        spinner-color="white"
                        style="max-height: 250px; max-width: 100%"
                        img-class="place-image"
                        class="rounded-borders"
                    />
                </div>
                <div class="q-px-md">
                    <p> {{placeInfo.placeDescription}}
                    </p>
                </div>
            </div>
            <div class="col-xs-12 col-md-3 q-ml-md vertical-hr">
                <div>
                    <p class="text-h6">Address:</p>
                    <p>{{placeInfo.placeAdress}}</p>
                </div>
                <div class="row items-center">
                    <p class="col-3"><q-icon name="far fa-envelope" class="icons" /></p>
                    <p class="col-9">{{placeInfo.placeEmail}}</p>
                </div>
                <div class="row items-center">
                    <p class="col-3"><q-icon name="fas fa-phone" class="icons" /></p>
                    <p class="col-9">{{placeInfo.phoneNumber}}</p>
                </div>
                <div class="row items-center">
                    <p class="col-3"><q-icon name="far fa-clock" class="icons" /></p>
                    <p class="col-9"> Çalışma saatlari: {{placeInfo.openingTime}} - {{placeInfo.closingTime}}
                    </p>
                </div>
                <div class="row items-center">
                    <p class="col-3"><q-icon name="fas fa-lira-sign" class="icons" /></p>
                    <p class="col-9">Ücret: {{placeInfo.entranceFee}}TL</p>
                </div>
            </div>
        </div>
        
        <hr />
        <q-btn to="/" label="back" color="teal" class="q-ma-md"/>
    </q-page>
</template>

<style lang="sass">
.place-image
  filter: blur(1px) sepia()
</style>

<style scoped>

.vertical-hr{
    border-left: 1px solid #666666;
}

.icons{
    font-size: 30px;
}
</style>

<script>
import axios from 'axios'
import { defineComponent , ref , computed} from 'vue';
import { useStore } from "vuex";

export default {
    props: ['placeId'],
    setup() {
        const store = useStore();
        let placeInfo = ref({});
        let placeId = localStorage.getItem("id"); 
        /*const place = computed(() => {
            return store.state.place;
        })
        console.log(place.value);*/
        const getPlaceInfo = () => {
            axios({
                url:"http://localhost:4000/api/place/GetPalceById/" + placeId,
                method: 'get'
            })
            .then((res) => {
                placeInfo.value = res.data;
                console.log(placeInfo.value);
            });
        } 
        getPlaceInfo();
        // placeInfo = place.value.place
        return{
            placeInfo
        } 
    },
}
</script>