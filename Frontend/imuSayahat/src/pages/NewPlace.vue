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
                            v-model="name"
                            type="text"
                            label="name *"
                            maxlength="50"
                            lazy-rules
                            :rules="[ val => val && val.length > 0 || 'Please type your name']"
                        />
                        <q-input
                            class="col-12 col-md-5"
                            v-model="phoneNumber"
                            label="Phone number *"
                            type="number"
                            lazy-rules
                            :rules="[ val => val && val.length > 0 || 'Please type your surname']"
                        />
                        <q-input
                            class="col-12 col-md-5"
                            v-model="email"
                            label="Email *"
                            type="email"
                            lazy-rules
                            :rules="[ val => val && val.length > 0 || 'Please type your surname']"
                        />
                        <q-input
                            class="col-12 col-md-5"
                            v-model="ucret"
                            type="number"
                            label="ucret *"
                            maxlength="50"
                            lazy-rules
                            :rules="[ val => val && val.length > 0 || 'Please type your surname']"
                        />
                        <q-input
                            class="col-12 col-md-5"
                            v-model="openingTime"
                            type="text"
                            label="opening time"
                            lazy-rules
                            :rules="[ val => val && val.length > 0 || 'Please type your born date']"
                        />
                        <q-input
                            class="col-12 col-md-5"
                            v-model="closingTime"
                            label="closing time"
                            type="text"
                            lazy-rules
                            :rules="[ val => val && val.length === 11 || 'Please type your surname']"
                        />
                        <q-input
                            class="col-12"
                            v-model="adress"
                            type="textarea"
                            label="Adress *"
                            lazy-rules
                            maxlength="100"
                            :rules="[ val => val && val.length > 0 || 'Please type tur description']"
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
                            v-model="desc"
                            type="textarea"
                            label="Description *"
                            lazy-rules
                            maxlength="100"
                            :rules="[ val => val && val.length > 0 || 'Please type tur description']"
                        />
                    </div>
                </div>
            </div>
            <div class="q-mx-lg">
                <q-btn label="Submit" type="submit" color="primary" />
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

        const name = ref(null);
        const ucret = ref(null);
        const imageUrl = ref(null);
        const email = ref(null);
        const desc = ref(null);
        const phoneNumber = ref(null);

        const openingTime = ref(null);
        const closingTime = ref(null);
        const adress = ref(null);
        
        const onSubmit = () => {
            axios({
                url:"http://localhost:58854/api/payment",
                method: 'post', 
                headers: {},
                data:{
                    id: 3,
                    name,
                    ucret,
                    imageUrl,
                    email,
                    desc,
                    phoneNumber,
                    adress,
                    openingTime,
                    closingTime
                }
            });
        };

        return{
            name,
            ucret,
            imageUrl,
            email,
            desc,
            phoneNumber,

            openingTime,
            closingTime,
            adress,

            onSubmit,
        }
    },
}
</script>