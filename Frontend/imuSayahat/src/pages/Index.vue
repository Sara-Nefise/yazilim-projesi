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
            <h2>IMU SAYAHAT</h2>
          </div>
          <div style="width: 50%">
            <q-input dark dense standout v-model="text" input-class="text-right">
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
        <div class="q-mb-lg">
          <q-select style="width: 20%" standout="bg-teal text-white" v-model="city" :options="options" label="City" />
        </div>
        <div class="row q-col-gutter-lg">
          <div 
            v-for="i in rang"
            :key="i"
            class="col-sm-12 col-md-4 col-lg-3 q-mb-md"
          >
            <q-card>
              <q-img src="https://cdn.quasar.dev/img/parallax2.jpg">
                <div class="absolute-bottom text-subtitle2 text-center">
                  Title
                </div>
              </q-img>
              <q-card-section>
              aaaaaaaaaaaaa aaaaaaaaaaaaa aaaaaaaaaaaa aaaaaaaaaaaaa aaaaaaaaaaaaa aaaaaaaaaaaaa 
              </q-card-section>
              
              <q-separator />
              
              <q-card-section>
                <q-btn to="/place" color="teal" label="More Information" />
              </q-card-section>
            </q-card>
          </div>
        </div>
        <div class="text-center">
          <q-btn unelevated color="teal" label="More Places" @click="morePlaces"/>
        </div>
      </div>
    </div>
  </q-page>
</template>

<script>
import { defineComponent , ref } from 'vue';

export default defineComponent({
  name: 'PageIndex',
  setup(){
    let rang = 10;
    const morePlaces = () => {
      rang = 20
      console.log(rang)
    }
    return{
      rang,
      morePlaces,
      text: ref(''),
      city: ref(null),
      options: [
        'Google', 'Facebook', 'Twitter', 'Apple', 'Oracle'
      ]
    }
  }
})
</script>

<style lang="sass">
.my-custom-image
  filter: blur(1px) sepia()
</style>
