<template>
    <q-page class="container">
        <div class="q-px-md">
            <h3>Place Name</h3>
        </div>
        <div class="row q-col-gutter-md justify-between">
            <div class="col-xs-12 col-md-8">
                <div class="q-px-md q-mb-xl">
                    <q-img
                        src="https://cdn.quasar.dev/img/parallax2.jpg"
                        spinner-color="white"
                        style="height: 250px; max-width: 100%"
                        img-class="place-image"
                        class="rounded-borders"
                    />
                </div>
                <div class="q-px-md">
                    <p> aaaaaaa aaaaaaaaaaa aaaaaaaaaaaa aaaaaaaaaaaaaaa aaaaaaaaaaa aaaaaaaaaaaa 
                        aaaaaaa aaaaaaaaaaa aaaaaaaaaaaa aaaaaaaaaaaaaaa aaaaaaaaaaa aaaaaaaaaaaa
                        aaaaaaa aaaaaaaaaaa aaaaaaaaaaaa aaaaaaaaaaaaaaa aaaaaaaaaaa aaaaaaaaaaaa
                        aaaaaaa aaaaaaaaaaa aaaaaaaaaaaa aaaaaaaaaaaaaaa aaaaaaaaaaa aaaaaaaaaaaa
                        aaaaaaa aaaaaaaaaaa aaaaaaaaaaaa aaaaaaaaaaaaaaa aaaaaaaaaaa aaaaaaaaaaaa
                        aaaaaaa aaaaaaaaaaa aaaaaaaaaaaa aaaaaaaaaaaaaaa aaaaaaaaaaa aaaaaaaaaaaa
                        aaaaaaa aaaaaaaaaaa aaaaaaaaaaaa aaaaaaaaaaaaaaa aaaaaaaaaaa aaaaaaaaaaaa
                        aaaaaaa aaaaaaaaaaa aaaaaaaaaaaa aaaaaaaaaaaaaaa aaaaaaaaaaa aaaaaaaaaaaa
                        aaaaaaa aaaaaaaaaaa aaaaaaaaaaaa aaaaaaaaaaaaaaa aaaaaaaaaaa aaaaaaaaaaaa
                        aaaaaaa aaaaaaaaaaa aaaaaaaaaaaa aaaaaaaaaaaaaaa aaaaaaaaaaa aaaaaaaaaaaa
                        aaaaaaa aaaaaaaaaaa aaaaaaaaaaaa aaaaaaaaaaaaaaa aaaaaaaaaaa aaaaaaaaaaaa
                        aaaaaaa aaaaaaaaaaa aaaaaaaaaaaa aaaaaaaaaaaaaaa aaaaaaaaaaa aaaaaaaaaaaa
                        aaaaaaa aaaaaaaaaaa aaaaaaaaaaaa aaaaaaaaaaaaaaa aaaaaaaaaaa aaaaaaaaaaaa
                        aaaaaaa aaaaaaaaaaa aaaaaaaaaaaa aaaaaaaaaaaaaaa aaaaaaaaaaa aaaaaaaaaaaa
                        aaaaaaa aaaaaaaaaaa aaaaaaaaaaaa aaaaaaaaaaaaaaa aaaaaaaaaaa aaaaaaaaaaaa
                        aaaaaaa aaaaaaaaaaa aaaaaaaaaaaa aaaaaaaaaaaaaaa aaaaaaaaaaa aaaaaaaaaaaa
                        aaaaaaa aaaaaaaaaaa aaaaaaaaaaaa aaaaaaaaaaaaaaa aaaaaaaaaaa aaaaaaaaaaaa
                        aaaaaaa aaaaaaaaaaa aaaaaaaaaaaa aaaaaaaaaaaaaaa aaaaaaaaaaa aaaaaaaaaaaa
                        aaaaaaa aaaaaaaaaaa aaaaaaaaaaaa aaaaaaaaaaaaaaa aaaaaaaaaaa aaaaaaaaaaaa
                    </p>
                </div>
            </div>
            <div class="col-xs-12 col-md-3 q-ml-md vertical-hr">
                <div>
                    <p class="text-h6">Address:</p>
                    <p>aaaaaa aaaaaaaaa aaaaaaaa aaaaaaaaaa aaaaaaaaa</p>
                </div>
                <div class="row items-center">
                    <p class="col-3"><q-icon name="far fa-envelope" class="icons" /></p>
                    <p class="col-9">aaaaaa aaaaaaaaa</p>
                </div>
                <div class="row items-center">
                    <p class="col-3"><q-icon name="fas fa-phone" class="icons" /></p>
                    <p class="col-9">aaaaaa aaaaaaaaa</p>
                </div>
                <div class="row items-center">
                    <p class="col-3"><q-icon name="far fa-clock" class="icons" /></p>
                    <p class="col-9"> aaaaaa aaaaaaaaa <br>
                        aaaaaa aaaaaaaaa <br>
                        aaaaaa aaaaaaaaa 
                    </p>
                </div>
                <div class="row items-center">
                    <p class="col-3"><q-icon name="fas fa-lira-sign" class="icons" /></p>
                    <p class="col-9">aaaaaa aaaaaaaaa</p>
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