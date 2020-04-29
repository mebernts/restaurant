<template>
    <div>
        <v-row>
            <v-col cols="12" sm="6" lg="4" xl="3" v-for="drink in drinks" :key="drink.id">
                <DrinkItem
                :id="drink.id"
                :name="drink.name"
                :price="drink.price"
                :category="drink.category"/>
            </v-col>
        </v-row>
    </div>
</template>

<script>
import axios from 'axios'
import DrinkItem from './DrinkItem.vue'
export default {
    data(){
        return{
            drinks: [{id: 400, name: "TestNameDrink", price: 35, category: "testCategory"}]
        }
    },

    created(){
        axios.get("https://localhost:5001/resturant/drinks")
        .then(result =>{
            console.log(result.data);
            this.drinks = result.data;
        }) // axios that gets information from the database
    },
    components:{
        DrinkItem
    }
    
}
</script>