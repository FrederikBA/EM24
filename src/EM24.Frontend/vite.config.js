import { defineConfig } from 'vite'
import react from '@vitejs/plugin-react'

// https://vitejs.dev/config/
export default defineConfig({
  build: {
    outDir: '../EM24.Web/wwwroot'
  },
  plugins: [react()],
  server: {
    port: 3000,
  }
})