<template>
   <div>
       <v-row>
           <v-col>
               <AppertizerItem
               :id="appertizer.id"
               :name="appertizer.name"
               :description="appertizer.description"
               :allergies="appertizer.allergies"
               :price="appertizer.price"
               :imageSrc="appertizer.imageSrc"
               :category="appertizer.category"/>
           </v-col>
       </v-row>
   </div>
</template>

<script>
import axios from 'axios'
import AppertizerItem from './AppertizerItem.vue'
export default {
    data(){
        return{
            appertizers:[{id: 999, name: "TestName", description: "TestDiscription", allergies: "TestAllergies", price: 106, imageSrc:"", category:"testCategory"}]
        }
    },
    created(){
        axios.get("https://localhost:5001/resturant/appertizer")
        .then(result =>{
            console.log(result.data);
            this.dishes = result.data;
        }) // axios that gets information from the database
    },
    components:{
        AppertizerItem
    }
}
</script>

    