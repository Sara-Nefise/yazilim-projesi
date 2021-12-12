<template>
  <q-page>
    <div style="width: 100%" class="q-mb-lg">
      <q-img
        src="https://cdn.quasar.dev/img/parallax2.jpg"
        spinner-color="white"
        style="height: 700px"
        img-class="my-custom-image"
        class="items-center"
      >
        <div class="absolute-center text-subtitle2 flex flex-center" style="width:100% ;background: none" >
          <div style="width: 100%" class="text-center">
            <h2>IMU SEYAHAT</h2>
          </div>
          <div style="width: 50%">
            <q-input dark dense standout v-model="text" @keydown="search" @keyup="search" placeholder="Please type place name here" input-class="text-right">
              <template v-slot:append>
                <q-icon v-if="text === ''" name="search" />
                <q-icon v-else name="clear" class="cursor-pointer" @click="text = ''" />
              </template>
            </q-input>
          </div>
        </div>
      </q-img>
    </div>
    <div class="container">
      <div class="q-pa-lg">
        <div class="q-mb-lg row q-gutter-lg">
          <q-select @input="filterByCity" class="col-5 col-md-3" standout="bg-teal text-white" v-model="city" :options="cities" label="City" />
          <q-btn class="col-5 col-md-3" to="/newplace" color="teal" label="Add Place" />

        </div>
        <div class="row q-col-gutter-lg">
          <div 
            v-for="place in filterdPlaces"
            :key="place.placeId"
            class="col-sm-12 col-md-4 col-lg-3 q-mb-md"
          >
            <q-card>
              <q-img src="https://cdn.quasar.dev/img/parallax2.jpg">
                <div class="absolute-bottom text-subtitle2 text-center">
                  {{place.placeName}}
                </div>
              </q-img>
              <q-card-section>
                {{place.placeDescription.slice(0, 50)}}....
              </q-card-section>
              
              <q-separator />
              
              <q-card-section>
                <q-btn @click="setId(place.placeId)" :to="{path: '/place/' + place.placeId}" color="teal" label="More Information" />
              </q-card-section>
            </q-card>
          </div>
        </div>
      </div>
    </div>
  </q-page>
</template>

<script>
import { defineComponent , ref , computed , watch} from 'vue';
import axios from 'axios';
import { useStore } from "vuex";

export default defineComponent({
  name: 'PageIndex',
  setup(){
    const store = useStore();
    const text = ref('');
    const city = ref('');
    const places = ref([]);
    const filterdPlaces = ref([]);
    const getplaces = () => {
      axios({
        url:"http://localhost:4000/api/place/get",
        method: 'get'
      })
      .then((res) => {
        places.value = res.data;
        filterdPlaces.value = res.data;
            console.log(filterdPlaces.value) 
      });
    }
    getplaces();
    
    const setId = (id) => {
      localStorage.setItem("id" , id)
    };

    const cities = computed(() => {
      return store.state.cities.cities;
    })

    watch(city.value , (currentValue, oldValue) => {
      console.log(city.value);
      filterByCity();
    })

    const search = () => {
      console.log(text.value);
      text.value.toUpperCase()
      if(text.value === ''){
        filterdPlaces.value = places.value;
        console.log(places.value)
        console.log(filterdPlaces.value)

      }
      else{
        filterdPlaces.value = places.value.filter((place) => {
          return place.placeName.includes(text.value);
        })
      }
    }

    const filterByCity = (val) => {
      console.log(val);
      console.log(filterdPlaces.value);

      filterdPlaces.value = places.value.filter((place) => {
        return place.cityName === city.value;
      })
    };
    
    return{
      text,
      city,
      places,
      setId,
      cities,
      filterdPlaces,
      filterByCity,
      search
    }
  }
})
</script>

<style lang="sass">
.my-custom-image
  filter: blur(1px) sepia()
</style>
