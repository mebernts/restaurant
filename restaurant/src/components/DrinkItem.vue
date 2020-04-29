<template>
    <article>
        <v-card>
            <!--<v-img :src="`https://localhost:5001/images/${imageSrc}`"
            height="200px">
            </v-img>-->
            <v-card-title>{{name}}</v-card-title>
            <v-card-text>
                <span>{{category}}</span>
                <span class="subtitle float-right font-weight-bold" >{{price}} Kr</span>
            </v-card-text>
            <v-card-text></v-card-text>
        </v-card>
    </article>
</template>

<script>
export default {
    props:{
        name:{
            type: String
        },
        price:{
            type: Number
        },
        category:{
            type: String
        }
    }
}
</script>