<template>
    <article>
        <v-card>
            <v-img
            :src="`https://localhost:5001/images/${imageSrc}`">
            </v-img>
            <v-card-title>{{name}}</v-card-title>
            <v-card-text>
                {{description}}
                {{allergies}}
                {{price}}
                {{category}}
            </v-card-text>
        </v-card>
    </article>
</template>

<script>
export default {
    props:{
        name:{
            type: String
        },
        description:{
            type: String
        },
        allergies:{
            type: String
        },
        price:{
            type: Number
        },
        imageSrc:{
            type: String
        },
        category:{
            type: String
        }
    
    }
}
</script>