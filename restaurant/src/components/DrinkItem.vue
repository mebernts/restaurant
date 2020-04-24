<template>
    <article>
        <v-card>
            <v-img :src="`https://localhost:5001/images/${imageSrc}`">
            </v-img>
            <v-card-title>{{name}}</v-card-title>
            <v-card-text>{{price}}</v-card-text>
            <v-card-text>{{category}}</v-card-text>
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