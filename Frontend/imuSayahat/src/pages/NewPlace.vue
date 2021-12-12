<template>
    <q-page class="q-ma-xl">
        <div class="q-pa-md">
            <q-form
            @submit="onSubmit"
            class="q-gutter-md"
            >
            <div class="row q-gutter-md">
                <h5 class="col-12">Place Information</h5>
                <div class="col-md-6">    
                    <div class="row q-gutter-md">
                        <q-input
                            class="col-12 col-md-5"
                            v-model="PlaceName"
                            type="text"
                            label="name *"
                            maxlength="50"
                            lazy-rules
                            :rules="[ val => val && val.length > 0 || 'Please type place name']"
                        />
                        <q-input
                            class="col-12 col-md-5"
                            v-model="PhoneNumber"
                            label="Phone number *"
                            type="text"
                            lazy-rules
                            :rules="[ val => val && val.length > 0 || 'Please type place phone number']"
                        />
                        <q-input
                            class="col-12 col-md-5"
                            v-model="PlaceEmail"
                            label="Email *"
                            type="email"
                            lazy-rules
                            :rules="[ val => val && val.length > 0 || 'Please type place email']"
                        />
                        <q-input
                            class="col-12 col-md-5"
                            v-model="EntranceFee"
                            type="text"
                            label="Entrance fee *"
                            maxlength="50"
                            lazy-rules
                            :rules="[ val => val && val.length > 0 || 'Please type place Entrance fee']"
                        />
                        <q-input
                            class="col-12 col-md-5"
                            v-model="OpeningTime"
                            type="text"
                            label="opening time"
                            lazy-rules
                            :rules="[ val => val && val.length > 0 || 'Please type place oppening time']"
                        />
                        <q-input
                            class="col-12 col-md-5"
                            v-model="ClosingTime"
                            label="closing time"
                            type="text"
                            lazy-rules
                            :rules="[ val => val && val.length > 0 || 'Please type place closing time']"
                        />
                        <q-select class="col-11" standout="bg-teal text-white" v-model="CityName" :options="cities" label="City" />

                        <q-input
                            class="col-11"
                            v-model="PlaceAdress"
                            type="textarea"
                            label="Adress *"
                            lazy-rules
                            maxlength="100"
                            :rules="[ val => val && val.length > 0 || 'Please type place address']"
                        />
                    </div>
                </div>
                <div class="col-md-5">
                    <div class="row q-gutter-md">
                        <q-input
                            class="col-12"
                            v-model="ImageURL"
                            type="text"
                            label="Image URL"
                            lazy-rules
                            :rules="[ val => val && val.length > 0 || 'Please add place image']"
                        />
                        <q-input
                            class="col-12"
                            v-model="PlaceDescription"
                            type="textarea"
                            label="Description *"
                            lazy-rules
                            :rules="[ val => val && val.length > 0 || 'Please type place description']"
                        />
                    </div>
                </div>
            </div>
            <div class="q-mx-lg">
                <q-btn label="Submit" type="submit" color="green" class="q-mr-md" />
                <q-btn label="Back" to="/" color="teal" />
            </div>
            </q-form>
        </div>
    </q-page>
</template>

<script>
import { useQuasar } from 'quasar'
import { ref , computed} from 'vue'
import axios from 'axios'
import { useStore } from 'vuex'

export default {
    setup() {
        const $q = useQuasar();
        const store = useStore();

        const PlaceName = ref('');
        const EntranceFee = ref(0);
        const ImageURL = ref('');
        const PlaceEmail = ref('');
        const PlaceDescription = ref('');
        const PhoneNumber = ref('');
        const CityName = ref('');
        const OpeningTime = ref('');
        const ClosingTime = ref('');
        const PlaceAdress = ref('');
        
        const onSubmit = () => {
            axios({
                url:"http://localhost:4000/api/place/post",
                method: 'post', 
                headers: {"Content-Type" : "application/json"},
                data:{
                    "PlaceName": PlaceName.value,
                    "CityName": CityName.value,
                    "PlaceAdress": PlaceAdress.value,
                    "PhoneNumber": PhoneNumber.value,
                    "PlaceEmail": PlaceEmail.value,
                    "OpeningTime": OpeningTime.value,
                    "ClosingTime": ClosingTime.value,
                    "EntranceFee": parseFloat(EntranceFee.value),
                    "PlaceDescription": PlaceDescription.value,
                    "ImageURL": ImageURL.value
                }
            });

        };
        
        const cities = computed(() => {
        return store.state.cities.cities;
        })

        return{
            PlaceName,
            EntranceFee,
            ImageURL,
            PlaceEmail,
            PlaceDescription,
            PhoneNumber,
            PlaceAdress,
            OpeningTime,
            ClosingTime,
            CityName,
            cities,
            onSubmit,
        }
    },
}
</script>