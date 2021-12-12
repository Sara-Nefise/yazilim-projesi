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
                            v-model="placeName"
                            type="text"
                            label="name *"
                            maxlength="50"
                            lazy-rules
                            :rules="[ val => val && val.length > 0 || 'Please type place name']"
                        />
                        <q-input
                            class="col-12 col-md-5"
                            v-model="phoneNumber"
                            label="Phone number *"
                            type="number"
                            lazy-rules
                            :rules="[ val => val && val.length > 0 || 'Please type place phone number']"
                        />
                        <q-input
                            class="col-12 col-md-5"
                            v-model="placeEmail"
                            label="Email *"
                            type="email"
                            lazy-rules
                            :rules="[ val => val && val.length > 0 || 'Please type place email']"
                        />
                        <q-input
                            class="col-12 col-md-5"
                            v-model="entranceFee"
                            type="number"
                            label="Entrance fee *"
                            maxlength="50"
                            lazy-rules
                            :rules="[ val => val && val.length > 0 || 'Please type place Entrance fee']"
                        />
                        <q-input
                            class="col-12 col-md-5"
                            v-model="openingTime"
                            type="datetime"
                            label="opening time"
                            lazy-rules
                            :rules="[ val => val && val.length > 0 || 'Please type place oppening time']"
                        />
                        <q-input
                            class="col-12 col-md-5"
                            v-model="closingTime"
                            label="closing time"
                            type="datetime"
                            lazy-rules
                            :rules="[ val => val && val.length > 0 || 'Please type place closing time']"
                        />
                        <q-select class="col-11" standout="bg-teal text-white" v-model="PlaceCity" :options="options" label="City" />

                        <q-input
                            class="col-11"
                            v-model="placeAdress"
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
                            v-model="imageUrl"
                            type="text"
                            label="Image URL"
                            lazy-rules
                            :rules="[ val => val && val.length > 0 || 'Please add place image']"
                        />
                        <q-input
                            class="col-12"
                            v-model="placeDescription"
                            type="textarea"
                            label="Description *"
                            lazy-rules
                            maxlength="100"
                            :rules="[ val => val && val.length > 0 || 'Please type place description']"
                        />
                    </div>
                </div>
            </div>
            <div class="q-mx-lg">
                <q-btn label="Submit" type="submit" color="green" />
            </div>
            </q-form>

        </div>
    </q-page>
</template>

<script>
import { useQuasar } from 'quasar'
import { ref } from 'vue'
import axios from 'axios'

export default {
    setup() {
        const $q = useQuasar()

        const placeName = ref(null);
        const entranceFee = ref(null);
        const imageUrl = ref(null);
        const placeEmail = ref(null);
        const placeDescription = ref(null);
        const phoneNumber = ref(null);
        const PlaceCity = ref(null);
        const openingTime = ref(null);
        const closingTime = ref(null);
        const placeAdress = ref(null);
        
        const onSubmit = () => {
            axios({
                url:"http://localhost:4000/api/place/post",
                method: 'post', 
                headers: {},
                data:{
                    placeName,
                    entranceFee,
                    imageUrl,
                    placeEmail,
                    placeDescription,
                    phoneNumber,
                    placeAdress,
                    openingTime,
                    closingTime,
                    PlaceCity
                }
            });
        };

        return{
            placeName,
            entranceFee,
            imageUrl,
            placeEmail,
            placeDescription,
            phoneNumber,
            placeAdress,
            openingTime,
            closingTime,
            PlaceCity,
            options: [
                'Google', 'Facebook', 'Twitter', 'Apple', 'Oracle'
            ],
            onSubmit,
        }
    },
}
</script>