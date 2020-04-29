<template>
   <div>
       <v-row>
           <v-col cols="12" sm="6" lg="4" xl="3" v-for="appertizer in appertizers" :key="appertizer.id">
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
            appertizers:[{id: 999, name: "TestNameAppertizer", description: "TestDiscription", allergies: "TestAllergies", price: 106, imageSrc:"", category:"testCategory"}]
        }
    },
    created(){
        axios.get("https://localhost:5001/resturant/appertizer")
        .then(result =>{
            this.appertizers = result.data;
        })
    },
    components:{
        AppertizerItem
    }
}
</script>

    