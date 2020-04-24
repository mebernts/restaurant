<template>
    <div>
        <v-row>
            <v-col>
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
import AppertizerItem from './DrinkItem.vue'
export default {
    data(){
        return{
            drinks: [{id: 400, name: "TestName", price: 35, category: "testCategory"}]
        }
    },

    created(){
        axios.get("https://localhost:5001/resturant/drinks")
        .then(result =>{
            console.log(result.data);
            this.dishes = result.data;
        }) // axios that gets information from the database
    },
    components:{
        DrinkItem
    }
    
}
</script>